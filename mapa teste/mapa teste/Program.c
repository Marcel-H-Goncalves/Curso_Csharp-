include <stdio.h>;

struct Candidato {
    int numero;
    char nome[50];
    int votos;
};

int votar(struct Candidato candidatos[], int totalCandidatos) {
    int voto;
    printf("Digite o número do candidato (1 a 99): ");
    scanf("%d", &voto);
    int encontrado = 0;
    for (int i = 0; i < totalCandidatos; i++) {
        if (candidatos[i].numero == voto) {
            candidatos[i].votos++;
            encontrado = 1;
            printf("Voto computado para %s!\n", candidatos[i].nome);
            return 1;
        }
    }
    if (encontrado) {
        printf("Número de candidato inválido!\n");
        return 0;
    }
    return 0;
}

void apurarVotos(struct Candidato candidatos[], int totalCandidatos) {
    printf("\nResultado da apuração de votos:\n");
    for (int i = 1; i <= totalCandidatos; i++) {
        printf("%s (Número %d): %d votos\n", candidatos[i].nome, candidatos[i].numero, candidatos[i].votos);
    }
}

void percentualVotos(struct Candidato candidatos[], int totalCandidatos, int totalVotos) {
    if (totalVotos == 0) {
        printf("Nenhum voto computado ainda.\n");
        return;
    }
    printf("\nPercentual de votos:\n");
    for (int i = 0; i < totalCandidatos; i++) {
        float percentual = candidatos[i].votos / totalVotos * 100;
        printf("%s: %.2f%% dos votos\n", candidatos[i].nome, percentual);
    }
}