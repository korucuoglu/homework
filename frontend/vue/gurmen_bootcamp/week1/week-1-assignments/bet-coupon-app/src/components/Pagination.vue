<template>
  <div class="pagination">
    <button @click="currentPage--">&laquo;</button>
    <button
      :class="{ active: number == currentPage }"
      v-for="number in endPage"
      :key="number"
      @click="currentPage = number"
    >
      {{ number }}
    </button>

    <button @click="currentPage++">&raquo;</button>
  </div>
</template>

<script>
export default {
  data() {
    return {
      currentPage: 1,
      endPage: 8,
    }
  },
  watch: {
    currentPage(n) {
      this.$emit('changed-page', n)
    },
  },
}
</script>

<style>
.pagination {
  display: inline-block;
  display: flex;
  justify-content: center;
  align-items: center;
}

.pagination button {
  color: black;
  float: left;
  padding: 8px 16px;
  text-decoration: none;
  transition: background-color 0.3s;
}

.pagination button.active {
  background-color: #4caf50;
  color: white;
}

.pagination button:hover:not(.active) {
  background-color: #ddd;
}
</style>
