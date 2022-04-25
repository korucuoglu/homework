<template>
  <div>
    <header>Kurs Planlaması</header>
    <div class="container">
      <div class="course--planner-app--container">
        <div class="card">
          <div class="user--action--container">
            <div class="form-group">
              <label>Kursun Adı</label>
              <input
                type="text"
                v-model="title"
                @keydown.enter="addCourse($event.target.value)"
              />
            </div>
            <button class="btn-primary" @click="addCourse(title)">
              Kurs Ekle
            </button>
          </div>
        </div>
        <div class="card card-light mt-20">
          <h3>Aktif Kurslarım</h3>
          <ul class="list mt-20">
            <li
              class="course-item list-item"
              :class="course.completed ? 'bg-success' : 'bg-danger'"
              v-for="course in courses"
              :key="course"
            >
              <span> {{ course.title }}</span>
              <input type="checkbox" v-model="course.completed" />
            </li>
          </ul>
        </div>
        <div class="mt-10">
          <small>İzlenecek {{ getUnompletedCourse }} adet kursunuz var.</small>
          <br />
          <small>İzlediğiniz {{ getCompletedCourse }} adet kursunuz var.</small>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  data() {
    return {
      title: '',
      courses: [
        { title: 'Vue.js', completed: false },
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
    getUnompletedCourse() {
      return this.courses.filter((x) => x.completed == false).length
    },
  },
}
</script>
