<template>
  <tr v-for="todo in provideData.todoList" :key="todo.Id">
    <TodoListItem :todo="todo" @completed-todo="todo.completed = true" />
  </tr>
</template>

<script>
import TodoListItem from './TodoListItem.vue'
export default {
  inject: ['provideData'],

  components: {
    TodoListItem,
  },
}
</script>
