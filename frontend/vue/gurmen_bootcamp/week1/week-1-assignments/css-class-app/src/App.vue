<template>
  <div>
    <header>CSS Class App</header>
    <div class="container css--class--app">
      <div class="card text-center">
        <ul class="css--palette text-center">
          <li
            v-for="color in colors"
            :key="color"
            :style="{ backgroundColor: color }"
            @click="changeColor(color)"
          ></li>
        </ul>
        <div
          class="result-box"
          :style="{ backgroundColor: selectedColor }"
        ></div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  data() {
    return {
      colors: ['red', 'green', 'blue'],
      selectedColor: null,
    }
  },

  methods: {
    changeColor(color) {
      this.selectedColor = color
    },
  },
}
</script>
