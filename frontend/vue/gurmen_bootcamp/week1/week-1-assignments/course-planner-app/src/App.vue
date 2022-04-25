<template>
  <div>
    <header>Kurs Planlaması</header>
    <div class="container">
      <div class="course--planner-app--container">
        <div class="card">
          <AddSection @add-course="addCourse" />
        </div>
        <CourseList :courses="courses" />

        <div class="mt-10">
          <ResultBar />
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import AddSection from './components/AddSection.vue'
import CourseList from './components/CourseList.vue'
import ResultBar from './components/ResultBar.vue'

export default {
  components: {
    AddSection,
    CourseList,
    ResultBar,
  },

  provide() {
    return {
      getCompletedCourse: this.getCompletedCourse,
      getUncompletedCourse: this.getUncompletedCourse,
    }
  },

  data() {
    return {
      title: '',
      courses: [
        { title: 'Vue.js', completed: true },
        { title: 'React.js', completed: false },
      ],
    }
  },
  methods: {
    addCourse(title) {
      this.courses.push({ title, completed: false })
    },
  },

  computed: {
    getCompletedCourse() {
      return this.courses.filter((x) => x.completed == true).length
    },
    getUncompletedCourse() {
      return this.courses.filter((x) => x.completed == false).length
    },
  },
}
</script>
