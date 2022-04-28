import axios from 'axios'

export const http = axios.create({
  baseURL: 'http://localhost:3000',
  header: {
    'X-Application-Name': 'vue',
    'Content-Type': 'application/json',
  },
})
