<template>
  <div class="pagination">
    <button @click="pageData.currentPage--">&laquo;</button>
    <button
      :class="{ active: number == pageData.currentPage }"
      v-for="number in pageData.endPage"
      :key="number"
      @click="getMatchList(number)"
    >
      {{ number }}
    </button>

    <button @click="pageData.currentPage++">&raquo;</button>
  </div>
</template>

<script>
export default {
  inject: ['pageData', 'getMatchList'],
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
