
namespace AysPro.Default {
    export interface AnswersRow {
        Id?: number;
        Guid?: string;
        Q1?: string;
        Q2?: string;
        Q3?: string;
        Q4?: string;
        Q5?: string;
        Q6?: string;
        Q7?: string;
        Q8?: string;
        Q9?: string;
        Q10?: string;
        Q11?: string;
        Q12?: string;
        Q13?: string;
        Q14?: string;
        Q15?: string;
        Q16?: string;
        Q17?: string;
        Q18?: string;
        Q19?: string;
        Q20?: string;
        Q21?: string;
        Date?: string;
        IpAdress?: string;
    }

    export namespace AnswersRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Q1';
        export const localTextPrefix = 'Default.Answers';

        export namespace Fields {
            export declare const Id;
            export declare const Guid;
            export declare const Q1;
            export declare const Q2;
            export declare const Q3;
            export declare const Q4;
            export declare const Q5;
            export declare const Q6;
            export declare const Q7;
            export declare const Q8;
            export declare const Q9;
            export declare const Q10;
            export declare const Q11;
            export declare const Q12;
            export declare const Q13;
            export declare const Q14;
            export declare const Q15;
            export declare const Q16;
            export declare const Q17;
            export declare const Q18;
            export declare const Q19;
            export declare const Q20;
            export declare const Q21;
            export declare const Date;
            export declare const IpAdress;
        }

        ['Id', 'Guid', 'Q1', 'Q2', 'Q3', 'Q4', 'Q5', 'Q6', 'Q7', 'Q8', 'Q9', 'Q10', 'Q11', 'Q12', 'Q13', 'Q14', 'Q15', 'Q16', 'Q17', 'Q18', 'Q19', 'Q20', 'Q21', 'Date', 'IpAdress'].forEach(x => (<any>Fields)[x] = x);
    }
}

