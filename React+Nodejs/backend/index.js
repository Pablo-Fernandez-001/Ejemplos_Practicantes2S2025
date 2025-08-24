const express = require("express");
const mysql = require("mysql2/promise");
const cors = require("cors");
require("dotenv").config();

const app = express();
app.use(cors());
app.use(express.json());

async function getPool() {
    if(!global._pool){
        global._pool = mysql.createPool({
            host: process.env.DB_HOST,
            user: process.env.DB_USER,
            password: process.env.DB_PASS,
            database: process.env.DB_NAME,
            waitForConnections: true,
            connectionLimit: 10,
        });
    }
    return global._pool;
}

app.get("/users", async(req, res) => {
    const pool = await getPool();
    const [rows] = await pool.query("SELECT * FROM users");
    res.json(rows);
});

app.post("/users", async (req, res) =>{
  const { name, email } = req.body;
  const pool = await getPool();
  const [result] = await pool.execute(
    "INSERT INTO users (name, email) VALUES (?, ?)",
    [name, email]
  );
  const [rows] = await pool.query("SELECT * FROM users WHERE id=?", [result.insertId]);
  res.json(rows[0]);
});


const PORT = process.env.PORT || 3001;
app.listen(PORT, () => console.log(`API on port http://localhost:${PORT} and it's running`))