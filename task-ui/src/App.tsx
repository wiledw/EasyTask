import React, { useState } from 'react';
import { TaskForm } from './components/TaskForm';
import { TaskList } from './components/TaskList';

function App() {
  const [refreshKey, setRefreshKey] = useState(0);
  
  return (
    <div style={{ maxWidth: 600, margin: '40px auto', padding: 20 }}>
      <h1>📝 Task Manager</h1>
      <TaskForm onAdd={() => setRefreshKey(k => k + 1)} />
      <TaskList refreshKey={refreshKey} />
    </div>
  );
}

export default App;

