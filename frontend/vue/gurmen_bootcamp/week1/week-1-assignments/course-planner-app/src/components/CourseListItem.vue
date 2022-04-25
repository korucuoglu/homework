<template>
  <li
    class="course-item list-item"
    :class="course.completed ? 'bg-success' : 'bg-danger'"
  >
    <span> {{ course.title }}</span>
    <input type="checkbox" v-model="course.completed" />
  </li>
</template>

<script>
export default {
  props: ['course_prop'],
  data() {
    return {
      course: this.course_prop, // burada prop ile birlikte mutation sorununu çözdük.
    }
  },
}
</script>
