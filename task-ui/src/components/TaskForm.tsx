import React, { useState } from 'react';
import { addTask } from '../api/task';

interface Props { onAdd: () => void; }

export const TaskForm: React.FC<Props> = ({ onAdd }) => {
  const [title, setTitle] = useState('');
  const submit = async (e: React.FormEvent) => {
    e.preventDefault();
    if (!title.trim()) return;
    await addTask(title.trim());
    setTitle('');
    onAdd();
  };

  return (
    <form onSubmit={submit} style={{ marginBottom: 16 }}>
      <input
        value={title}
        onChange={e => setTitle(e.target.value)}
        placeholder="New task"
        style={{ padding: 8, width: '70%' }}
      />
      <button type="submit" style={{ padding: 8, marginLeft: 8 }}>
        Add
      </button>
    </form>
  );
};
