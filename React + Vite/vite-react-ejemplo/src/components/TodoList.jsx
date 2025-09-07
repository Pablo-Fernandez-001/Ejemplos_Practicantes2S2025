import React from 'react'
import TodoItem from './TodoItem'


export default function TodoList({ todos = [], onToggle, onRemove }) {
    if (todos.length === 0) return <p className="empty">No hay tareas — añade la primera</p>


    return (
        <ul className="todo-list">
            {todos.map(t => (
                <TodoItem key={t.id} todo={t} onToggle={() => onToggle(t.id)} onRemove={() => onRemove(t.id)} />
            ))}
        </ul>
    )
}