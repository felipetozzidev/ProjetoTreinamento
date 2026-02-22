export type APIResponse<T = unknown> = {
  sucesso: boolean,
  retorno: T,
  mensagem: string
}
