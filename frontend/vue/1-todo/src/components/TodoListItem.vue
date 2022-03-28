<template>
  <th>{{ todo.Id }}</th>
  <td>{{ todo.text }}</td>
  <td>{{ todo.completed ? 'Tamamlandı' : 'Tamamlanmadı' }}</td>
  <td>
    <button
      type="button"
      class="btn btn-danger"
      @click.prevent="deleteTodo(todo)"
    >
      Delete
    </button>
    <button
      type="button"
      class="btn btn-success ms-1"
      :class="{ disabled: todo.completed }"
      @click.prevent="$emit('completed-todo', todo)"
    >
      Finished
    </button>
  </td>
</template>
<script>
export default {
  props: ['todo'],
  inject: ['deleteTodo'],
}
</script>
