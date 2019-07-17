export interface GbExercise
{
    Name: string;
    Description: string;
    Tags: string[];
}

export interface GbEffort<T>
{
    Effort: T;
}

export class GbDuration implements IEffort
{
    Hours: number;
    Minutes: number;
    Seconds: number;
}

export class GbReps implements IEffort
{
    Reps: number;
    GapBetween: number;
}

export interface GbStation<IEffort>
{
    Exercise: GbExercise;
    Effort: GbEffort<IEffort>;
    RestDuration: GbDuration;
}

export interface GbRoutine
{
    WorkoutStations: GbStation<IEffort>[];
}

export interface GbWorkout {
    Name: string;
    Desc: string;
    Tags: string[];
    WoroutRoutine: GbRoutine;
}

export interface IEffort {}