function doPost() {
    const form = document.querySelector("#post");
    const name = form.querySelector("[name=name]").value;
    const surname = form.querySelector("[name=surname]").value;

    if (!name || !surname) {
        alert("POST fields are required");
        return false;
    } else {
        return confirm("Send with POST?");
    }
}