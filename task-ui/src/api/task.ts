import axios from 'axios';

export interface Task {
  id: number;
  title: string;
  isComplete: boolean;
}

const api = axios.create({
  baseURL: process.env.REACT_APP_API_BASE_URL,
});

export const fetchTasks = () => api.get<Task[]>('/');
export const addTask    = (title: string) =>
  api.post<Task>('/', { title });
export const toggleTask = (id: number) =>
  api.put(`/${id}/toggle`);
export const deleteTask = (id: number) =>
  api.delete(`/${id}`);
