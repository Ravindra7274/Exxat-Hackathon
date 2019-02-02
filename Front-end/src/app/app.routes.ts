import {HomeComponent} from "./pages/home/home.component";

export const appRoutes=[
    {
        path:'',
        redirectTo:'home',
        pathMatch:'full'
    },
    {
        path: 'home',
        component: HomeComponent
    },
    {
        path: 'others',
        loadChildren:'./pages/others/others.module#OthersModule',
    },
    {
        path: 'students',
        loadChildren:'./pages/students/students.module#StudentsModule',
    },
    {
        path: 'placement',
        loadChildren:'./pages/others/others.module#OthersModule',
    },
    {
        path: 'evaluation',
        loadChildren:'./pages/others/others.module#OthersModule',
    },
    {
        path: 'patientlog',
        loadChildren:'./pages/others/others.module#OthersModule',
    }
];