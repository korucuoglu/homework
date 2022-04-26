<template>
  <div class="card--body">
    <div class="competition-item">
      <div class="info--container">
        <span class="font-weight-bold"
          >{{ match.home }} x {{ match.away }}</span
        >
        <small class="text-muted mt-5"
          ><i>Saat : {{ match.clock }}</i></small
        >
      </div>
      <div class="rates">
        <div class="rate-item">
          <button class="btn-sm" @click="addBet(match.id, 'home')">
            {{ match.rates.home }}
          </button>
        </div>
        <div class="rate-item">
          <button class="btn-sm" @click="addBet(match.id, 'draw')">
            {{ match.rates.draw }}
          </button>
        </div>
        <div class="rate-item">
          <button class="btn-sm" @click="addBet(match.id, 'away')">
            {{ match.rates.away }}
          </button>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  props: ['match'],
  inject: ['addBet'],
}
</script>
