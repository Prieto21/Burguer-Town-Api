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
  const burguer = await pool.query('SELECT nombre, imagen, valor FROM productos WHERE id_clasificacion = 1;');
  res.json(burguer);
});

// Productos (Bebidas)
router.get('/bebidas', async (req, res) => {
  const bebidas = await pool.query('SELECT nombre, imagen, valor FROM productos WHERE id_clasificacion = 2;');
  res.json(bebidas);
});

// Pedidos activos
router.get('/activos', async (req, res) => {
  const activos = await pool.query('SELECT pr.imagen, pr.nombre producto, u.nombre usuario , u.direccion, pe.valor , pe.cantidad, e.estado FROM pedidos pe, estado e, productos pr, usuario u WHERE pe.id_producto = pr.id_producto AND pe.id_usuario = u.id_usuario AND pe.id_estado = e.id_estado AND pe.id_estado = 1;');
  res.json(activos);
});

// Pedidos cancelados
router.get('/cancel', async (req, res) => {
  const cancel = await pool.query('SELECT pr.imagen, pr.nombre producto, u.nombre usuario , u.direccion, pe.valor , pe.cantidad, e.estado FROM pedidos pe, estado e, productos pr, usuario u WHERE pe.id_producto = pr.id_producto AND pe.id_usuario = u.id_usuario AND pe.id_estado = e.id_estado AND pe.id_estado = 2;');
  res.json(cancel);
});

// Carrito de compra
router.get('/carrito', async (req, res) => {
  const cars = await pool.query('SELECT p.nombre , p.imagen FROM carrito c, productos p, usuario u WHERE c.id_producto = p.id_producto AND u.id_usuario = c.id_usuario AND u.id_usuario = 5;');
  res.json(cars);
});


module.exports = router;