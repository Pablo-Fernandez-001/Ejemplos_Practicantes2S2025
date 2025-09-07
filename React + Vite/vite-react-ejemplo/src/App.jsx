import React, { useState } from 'react'
import Header from './components/Header'
import TodoInput from './components/TodoInput'
import TodoList from './components/TodoList'

export default function App() {
    const [todos, setTodos] = useState([
        { id: 1, text: 'Aprender Vite + React', done: false }
    ])
    


    const addTodo = (text) => {
        const t = text?.trim()
        if (!t) return
        setTodos(prev => [...prev, { id: Date.now(), text: t, done: false }])
    }


    const toggleDone = (id) => {
        setTodos(prev => prev.map(t => t.id === id ? { ...t, done: !t.done } : t))
    }


    const removeTodo = (id) => {
        setTodos(prev => prev.filter(t => t.id !== id))
    }


    return (
        <div className="app">
            <Header />
            <main>
                <TodoInput onAdd={addTodo} />
                <TodoList todos={todos} onToggle={toggleDone} onRemove={removeTodo} />
            </main>
        </div>
    )
}