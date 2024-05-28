import { Test1TemplatePage } from './app.po';

describe('Test1 App', function() {
  let page: Test1TemplatePage;

  beforeEach(() => {
    page = new Test1TemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
