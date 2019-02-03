
import { SupportProblem } from "./support.problem.model";
export class SupportTool{

    Categories:string;
    Problem:SupportProblem[];

    SupportTool(tool){
        this.Categories=tool.Categories || "";
        this.Problem=tool.Problem || [];
    }
}