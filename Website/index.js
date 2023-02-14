window.onload = function() {
    const t1_1 = document.getElementById("1_1");
    const t1_2 = document.getElementById("1_2");
    const t1_3 = document.getElementById("1_3");
    const t1_4 = document.getElementById("1_4");
    const t1_5 = document.getElementById("1_5");
    const t1_6 = document.getElementById("1_6");
    const t1_7 = document.getElementById("1_7");
    const t1_8 = document.getElementById("1_8");
    const t2_1 = document.getElementById("2_1");
    const t2_2 = document.getElementById("2_2");
    const t2_3 = document.getElementById("2_3");
    const t2_4 = document.getElementById("2_4");
    const t2_5 = document.getElementById("2_5");
    const t2_6 = document.getElementById("2_6");
    const t2_7 = document.getElementById("2_7");
    const t2_8 = document.getElementById("2_8");
    const t3_1 = document.getElementById("3_1");
    const t3_2 = document.getElementById("3_2");
    const t3_3 = document.getElementById("3_3");
    const t3_4 = document.getElementById("3_4");
    const t3_5 = document.getElementById("3_5");
    const t3_6 = document.getElementById("3_6");
    const t3_7 = document.getElementById("3_7");
    const t3_8 = document.getElementById("3_8");
    const t4_1 = document.getElementById("4_1");
    const t4_2 = document.getElementById("4_2");
    const t4_3 = document.getElementById("4_3");
    const t4_4 = document.getElementById("4_4");
    const t4_5 = document.getElementById("4_5");
    const t4_6 = document.getElementById("4_6");
    const t4_7 = document.getElementById("4_7");
    const t4_8 = document.getElementById("4_8");
    const t5_1 = document.getElementById("5_1");
    const t5_2 = document.getElementById("5_2");
    const t5_3 = document.getElementById("5_3");
    const t5_4 = document.getElementById("5_4");
    const t5_5 = document.getElementById("5_5");
    const t5_6 = document.getElementById("5_6");
    const t5_7 = document.getElementById("5_7");
    const t5_8 = document.getElementById("5_8");
    const t6_1 = document.getElementById("6_1");
    const t6_2 = document.getElementById("6_2");
    const t6_3 = document.getElementById("6_3");
    const t6_4 = document.getElementById("6_4");
    const t6_5 = document.getElementById("6_5");
    const t6_6 = document.getElementById("6_6");
    const t6_7 = document.getElementById("6_7");
    const t6_8 = document.getElementById("6_8");
    var nume = document.getElementById("name");
    const downloadButton = document.getElementById("download-button");

    downloadButton.addEventListener("click", function() {
      const data = {
        q1 : {
            q: q1.value,
            a1: t1_1.value,
            a2: t1_2.value,
            a3: t1_3.value,
            a4: t1_4.value,
            a5: t1_5.value,
            a6: t1_6.value,
            a7: t1_7.value,
            a8: t1_8.value
        },
        q2 : {
            q: q2.value,
            a1: t2_1.value,
            a2: t2_2.value,
            a3: t2_3.value,
            a4: t2_4.value,
            a5: t2_5.value,
            a6: t2_6.value,
            a7: t2_7.value,
            a8: t2_8.value3
        },
        q3 : {
            q: q3.value,
            a1: t3_1.value,
            a2: t3_2.value,
            a3: t3_3.value,
            a4: t3_4.value,
            a5: t3_5.value,
            a6: t3_6.value,
            a7: t3_7.value,
            a8: t3_8.value
        },
        q4 : {
            q: q4.value,
            a1: t4_1.value,
            a2: t4_2.value,
            a3: t4_3.value,
            a4: t4_4.value,
            a5: t4_5.value,
            a6: t4_6.value,
            a7: t4_7.value,
            a8: t4_8.value
        },
        q5 : {
            q: q5.value,
            a1: t5_1.value,
            a2: t5_2.value,
            a3: t5_3.value,
            a4: t5_4.value,
            a5: t5_5.value,
            a6: t5_6.value,
            a7: t5_7.value,
            a8: t5_8.value
        },
        q6 : {
            q: q6.value,
            a1: t6_1.value,
            a2: t6_2.value,
            a3: t6_3.value,
            a4: t6_4.value,
            a5: t6_5.value,
            a6: t6_6.value,
            a7: t6_7.value,
            a8: t6_8.value
        }
      };
      if (nume == undefined) {
        nume = "fara_nume"
      }
      const json = JSON.stringify(data);
      const blob = new Blob([json], { type: "application/json" });
      const href = URL.createObjectURL(blob);
      const link = document.createElement("a");
      link.href = href;
      link.download = nume.value + ".json";
      link.click();
    });
};