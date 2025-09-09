import cv2
import numpy as np

# Carregar imagem
img = cv2.imread("imagem.png")

# Criar máscara onde está a marca d'água (manual ou automática)
# Aqui, supondo que já temos uma máscara binária "mask.png"
mask = cv2.imread("mask.png", 0)

# Aplicar inpainting
resultado = cv2.inpaint(img, mask, 3, cv2.INPAINT_TELEA)

# Salvar
cv2.imwrite("imagem_sem_marca.jpg", resultado)
