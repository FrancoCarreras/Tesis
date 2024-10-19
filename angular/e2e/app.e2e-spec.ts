import { AdminFutbolTemplatePage } from './app.po';

describe('AdminFutbol App', function() {
  let page: AdminFutbolTemplatePage;

  beforeEach(() => {
    page = new AdminFutbolTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
