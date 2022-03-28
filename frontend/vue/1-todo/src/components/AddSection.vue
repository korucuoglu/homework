<template>
  <div class="form-outline">
    <input
      type="text"
      id="form1"
      class="form-control"
      @keydown.enter.prevent="addTodo"
    />
    <label class="form-label" for="form1">Enter a task here</label>
  </div>
</template>

<script>
export default {
  inject: ['addTodo'],
}
</script>
