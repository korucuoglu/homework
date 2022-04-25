<template>
  <div class="card card-light mt-20">
    <h3>Aktif Kurslarım</h3>
    <ul class="list mt-20">
      <CorseListItem
        v-for="course in courses"
        :key="course"
        :course_prop="course"
      />
    </ul>
  </div>
</template>

<script>
import CorseListItem from './CourseListItem.vue'
export default {
  components: {
    CorseListItem,
  },
  props: ['courses'],
}
</script>
