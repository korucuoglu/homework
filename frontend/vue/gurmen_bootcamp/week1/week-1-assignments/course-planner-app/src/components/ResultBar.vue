<template>
  <small>İzlenecek {{ getUncompletedCourse }} adet kursunuz var.</small>
  <br />
  <small>İzlediğiniz {{ getCompletedCourse }} adet kursunuz var.</small>
</template>

<script>
export default {
  inject: ['getCompletedCourse', 'getUncompletedCourse'],
}
</script>
