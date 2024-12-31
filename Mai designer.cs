<div class="parameter-row">
  <div class="parameter-label">
      <span>Tube Mill </span>
      <span class="unit-label"></span>
  </div>
   
  <div class="readings-heading">
      <div class="TM1reading-box">
          TM1
      </div>
      <div class="TM2reading-box">TM2</div>
      <div class="TM3reading-box">TM3</div>
      <div class="TM4reading-box">TM4</div>
      <div class="TM7reading-box">TM7</div>
  </div>
</div>

<div class="readings-heading">
    <!-- HFError and MillError for TM1 -->
    <div class="TM1reading-box">
        <div class="hf-error" data-value="@Model.HFError.TM1Value.ToString()">HF</div>
        <div class="mill-error" data-value="@Model.MillError.TM1Value.ToString()">Mill</div>
    </div>

    <!-- HFError and MillError for TM2 -->
    <div class="TM2reading-box">
        <div class="hf-error" data-value="@Model.HFError.TM2Value.ToString()">HF</div>
        <div class="mill-error" data-value="@Model.MillError.TM2Value.ToString()">Mill</div>
    </div>

    <!-- HFError and MillError for TM3 -->
    <div class="TM3reading-box">
        <div class="hf-error" data-value="@Model.HFError.TM3Value.ToString()">HF</div>
        <div class="mill-error" data-value="@Model.MillError.TM3Value.ToString()">Mill</div>
    </div>

    <!-- HFError and MillError for TM4 -->
    <div class="TM4reading-box">
        <div class="hf-error" data-value="@Model.HFError.TM4Value.ToString()">HF</div>
        <div class="mill-error" data-value="@Model.MillError.TM4Value.ToString()">Mill</div>
    </div>

    <!-- HFError and MillError for TM7 -->
    <div class="TM7reading-box">
        <div class="hf-error" data-value="@Model.HFError.TM7Value.ToString()">HF</div>
        <div class="mill-error" data-value="@Model.MillError.TM7Value.ToString()">Mill</div>
    </div>
</div>
