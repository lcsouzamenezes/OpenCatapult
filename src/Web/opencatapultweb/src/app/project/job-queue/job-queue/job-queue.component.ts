import { Component, OnInit } from '@angular/core';
import { JobQueueService, JobDto, JobQueueFilterType } from '@app/core';
import { ActivatedRoute } from '@angular/router';
import { JobStatus } from '@app/core/enums/job-status';
import { MatTabChangeEvent } from '@angular/material';

@Component({
  selector: 'app-job-queue',
  templateUrl: './job-queue.component.html',
  styleUrls: ['./job-queue.component.css']
})
export class JobQueueComponent implements OnInit {
  projectId: number;
  currentJobs: JobDto[] = [];
  pendingJobs: JobDto[] = [];
  pastJobs: JobDto[];
  loading: boolean;

  constructor(
    private route: ActivatedRoute,
    private jobQueueService: JobQueueService
  ) { }

  ngOnInit() {
    this.projectId = +this.route.parent.parent.snapshot.params.id;
    this.getCurrentJobQueues();
  }

  getCurrentJobQueues(): void {
    this.loading = true;
    this.jobQueueService.getJobQueues(this.projectId, JobQueueFilterType.current)
      .subscribe(jobs => {
        this.currentJobs = jobs.filter(job => job.status === JobStatus.Queued || job.status === JobStatus.Processing);
        this.pendingJobs = jobs.filter(job => job.status === JobStatus.Pending);
        this.loading = false;
      });
  }

  getPastJobQueues(): void {
    this.loading = true;
    this.jobQueueService.getJobQueues(this.projectId, JobQueueFilterType.past)
      .subscribe(jobs => {
        this.pastJobs = jobs;
        this.loading = false;
      });
  }

  onTabChanged(evt: MatTabChangeEvent) {
    if (evt.index === 2) {
      this.getPastJobQueues();
    } else {
      this.getCurrentJobQueues();
    }
  }

}
