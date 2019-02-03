import { SupportTroubleshoot } from "./support.troubleshoot.model";


export class SupportProblem{
    PreCheckName:string;
    InitialQuery:string;
    Troubleshoot:SupportTroubleshoot[];

    SupportProblem(problem){
        this.PreCheckName=problem.PreCheckName || '';
        this.InitialQuery=problem.InitialQuery || '';
        this.Troubleshoot=problem.Troubleshoot || '';
    }
}