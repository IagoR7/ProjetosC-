import customtkinter as cus


cus.set_appearance_mode("dark")
janela = cus.CTk("#1E90FF")
janela.geometry("800x800")
janela.title("Sistema de Acesso")
janela.iconbitmap("ic_vpn_lock_128_28770.ico")

cus.CTkLabel(janela,
             text="Sistema de Acesso",
             font=("arial", 45 , "bold"),
             text_color="yellow").pack(pady=20)

login = cus.CTkEntry(janela,
                     width=400,
                     height=40,
                     placeholder_text="Digite o seu login")

login.pack()

senha = cus.CTkEntry(janela,
                     width=400,
                     height=40,
                     placeholder_text="Digite a sua senha",
                     show="*")

senha.pack(pady = 10)

botao = cus.CTkButton(janela,
                      width=150,
                      height=30,
                      fg_color="gray",
                      text='Acessar',
                      cursor="hand2",
                      text_color="black")

botao.pack(pady = 10)



janela.mainloop()
