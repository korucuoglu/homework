<template>
  <div class="pagination">
    <button :disabled="currentPage == 1" @click="currentPage--">&laquo;</button>
    <button
      :class="{ active: number == currentPage }"
      v-for="number in endPage"
      :key="number"
      @click="currentPage = number"
    >
      {{ number }}
    </button>

    <button :disabled="currentPage == endPage" @click="currentPage++">
      &raquo;
    </button>
  </div>
</template>

<script>
export default {
  data() {
    return {
      currentPage: 1,
      endPage: 9,
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
  gap: 0.2rem;
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
