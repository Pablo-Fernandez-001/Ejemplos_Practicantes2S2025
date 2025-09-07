import React, { useState } from 'react'


export default function TodoInput({ onAdd }) {
    const [value, setValue] = useState('')


    const handleSubmit = (e) => {
        e.preventDefault()
        onAdd(value)
        setValue('')
    }


    return (
        <form className="todo-input" onSubmit={handleSubmit}>
            <input
                value={value}
                onChange={e => setValue(e.target.value)}
                placeholder="Añade una tarea..."
                aria-label="Nueva tarea"
            />
            <button type="submit">Agregar</button>
        </form>
    )
}