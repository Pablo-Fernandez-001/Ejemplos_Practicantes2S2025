import React from 'react'


// src/components/TodoItem.jsx
export default function TodoItem({ todo, onToggle, onRemove }) {
  return (
    <li className={`todo-item ${todo.done ? 'done' : ''}`}>
      <label>
        <input type="checkbox" checked={todo.done} onChange={onToggle} />
        <span className="text">{todo.text}</span>
      </label>
      <button className="btn-remove" onClick={onRemove} aria-label="Eliminar">
        ✖
      </button>
    </li>
  )
}
