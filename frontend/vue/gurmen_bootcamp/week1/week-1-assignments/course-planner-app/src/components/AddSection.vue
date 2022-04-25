<template>
  <div class="user--action--container">
    <div class="form-group">
      <label>Kursun Adı</label>
      <input
        type="text"
        v-model="title"
        @keydown.enter="addCourse($event.target.value)"
      />
    </div>
    <button class="btn-primary" @click="addCourse(title)">Kurs Ekle</button>
  </div>
</template>

<script>
export default {}
</script>
