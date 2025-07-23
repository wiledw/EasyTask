import React from 'react';
import { Task, toggleTask, deleteTask } from '../api/task';

interface Props {
  task: Task;
  onChange: () => void;
}

export const TaskItem: React.FC<Props> = ({ task, onChange }) => {
  const handleToggle = async () => {
    await toggleTask(task.id);
    onChange();
  };

  const handleDelete = async () => {
    await deleteTask(task.id);
    onChange();
  };

  return (
    <li style={{
      display: 'flex',
      alignItems: 'center',
      marginBottom: 8
    }}>
      <input
        type="checkbox"
        checked={task.isComplete}
        onChange={handleToggle}
      />
      <span
        onClick={handleToggle}
        style={{
          flex: 1,
          marginLeft: 8,
          textDecoration: task.isComplete ? 'line-through' : undefined,
          cursor: 'pointer'
        }}
      >
        {task.title}
      </span>
      <button
        onClick={handleDelete}
        style={{
          marginLeft: 8,
          background: 'transparent',
          border: 'none',
          color: 'red',
          cursor: 'pointer'
        }}
      >
        ✕
      </button>
    </li>
  );
};
