import { TestBed } from '@angular/core/testing';

import { TeamValueService } from './team-value-service.service';

describe('TeamValueServiceService', () => {
  let service: TeamValueService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(TeamValueService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
