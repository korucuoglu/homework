<template>
  <div class="pagination">
    <a href="#">&laquo;</a>
    <a href="#">1</a>
    <a href="#" class="active">2</a>
    <a href="#">3</a>
    <a href="#">4</a>
    <a href="#">5</a>
    <a href="#">6</a>
    <a href="#">&raquo;</a>
  </div>
</template>

<script>
export default {}
</script>

<style>
.pagination {
  display: inline-block;
  display: flex;
  justify-content: center;
  align-items: center;
}

.pagination a {
  color: black;
  float: left;
  padding: 8px 16px;
  text-decoration: none;
  transition: background-color 0.3s;
}

.pagination a.active {
  background-color: #4caf50;
  color: white;
}

.pagination a:hover:not(.active) {
  background-color: #ddd;
}
</style>
