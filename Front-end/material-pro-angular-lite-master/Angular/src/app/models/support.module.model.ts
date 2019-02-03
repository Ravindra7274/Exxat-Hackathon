export class SupportModule{
    moduleId:string;
    name:string;
    commonQueries:string;

    SupportTroubleshoot(problem){
        this.moduleId=problem.moduleId || '';
        this.name=problem.name || '';
        this.commonQueries=problem.commonQueries || '';
    }
    
}