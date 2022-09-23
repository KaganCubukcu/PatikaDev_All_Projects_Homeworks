import App from "./App";
import { render, screen, fireEvent } from "@testing-library/react";
import "@testing-library/jest-dom";

describe("App Tests", () => {
  beforeEach(() => {
    render(<App />);
  });

  test("Header Test", () => {
    const header = screen.getByText("Emoji Search");
    expect(header).toBeInTheDocument();
  });

  test("Emoji list test", () => {
    const items = screen.getAllByText("Click to copy emoji");
    expect(items.length).toEqual(20);
  });

  test("Filtering test", () => {
    const emoji = "Smile";
    const input = screen.getByRole("textbox");
    fireEvent.change(input, { target: { value: emoji } });

    expect(screen.getByText(emoji)).toBeInTheDocument();
  });

  test("Copying test", () => {
    const click = screen.getAllByText("Click to copy emoji").at(0);
    const parent = click.parentElement;
    expect(parent.getAttribute("data-clipboard-text").length).toBeGreaterThan(
      0
    );
  });
});
