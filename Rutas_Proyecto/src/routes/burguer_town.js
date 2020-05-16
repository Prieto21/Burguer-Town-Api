const express = require('express');

const router = express.Router();
const pool = require('../database.js');
// Informacion del usuario
router.get('/user', async (req, res) => {
  const usuarios = await pool.query('SELECT * FROM usuario');
  res.json(usuarios);
});

// Productos (Hamburguesas)
router.get('/burger', async (req, res) => {
  const burguer = await pool.query('SELECT nombre, imagen, descripcion FROM productos WHERE id_clasificacion = 1;');
  res.json(burguer);
});

// Productos (Bebidas)
router.get('/bebidas', async (req, res) => {
  const bebidas = await pool.query('SELECT nombre, imagen, descripcion FROM productos WHERE id_clasificacion = 2;');
  res.json(bebidas);
});

//agregar usuarios
router.post('/user/add',async(req,res)=>{

  const datos = {
      nombre: req.body.nombre,
      apellido: req.body.apellido,
      user: req.body.user,
      pass: req.body.pass
  }; 
  
  const sql = 'INSERT INTO usuario SET ?';
  await pool.query(sql,datos);
  res.sendStatus(200);

});

//agregar Productos Clasificados
router.post('/product/add',async(req,res)=>{

  const datos = {
      nombre: req.body.nombre,
      imagen: req.body.imagen,
      descripcion: req.body.descripcion,
      id_clasificacion: req.body.id_clasificacion
  }; 
  
  const sql = 'INSERT INTO productos SET ?';
  await pool.query(sql,datos);
  res.sendStatus(200);

});




module.exports = router;