//CREATE
const hape = document.getElementById('hape');
const modal_container = document.getElementById('modali_kontenjeti');
const closeCreate = document.getElementById('close');

hapeCreate.addEventListener('click', () => {
    modal_container.classList.add('show');
});

closeCreate.addEventListener('click', () => {
    modal_container.classList.remove('show');
});


const hapeEdit = document.getElementById('hapeEdit');
const modal_containerEdit = document.getElementById('edit_modali_kontenjeti');
const closeEdit = document.getElementById('closeEdit');


hapeEdit.addEventListener('click', () => {
    modal_containerEdit.classList.add('Editshow');
});

closeEdit.addEventListener('click', () => {
    modal_containerEdit.classList.remove('Editshow');
});
