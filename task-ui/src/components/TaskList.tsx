import React, { useEffect, useState } from 'react';
import { Task, fetchTasks } from '../api/task';
import { TaskItem } from './TaskItem';

export const TaskList: React.FC<{ refreshKey: number }> = ({ refreshKey }) => {
  const [tasks, setTasks] = useState<Task[]>([]);

  const load = async () => {
    const res = await fetchTasks();
    setTasks(res.data);
  };

  useEffect(() => {
    load();
  }, [refreshKey]);

  return (
    <ul style={{ listStyle: 'none', padding: 0 }}>
      {tasks.map(t => (
        <TaskItem key={t.id} task={t} onChange={load} />
      ))}
    </ul>
  );
};
