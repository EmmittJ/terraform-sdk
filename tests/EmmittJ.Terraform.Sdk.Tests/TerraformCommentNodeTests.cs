namespace EmmittJ.Terraform.Sdk.Tests;

public class TerraformCommentNodeTests
{
    [Fact]
    public void Constructor_WithText_SetsText()
    {
        const string commentText = "This is a comment";

        var comment = new TerraformCommentNode(commentText);

        Assert.Equal(commentText, comment.Text);
    }

    [Fact]
    public void Constructor_WithNullText_ThrowsArgumentNullException()
    {
        Assert.Throws<ArgumentNullException>(() => new TerraformCommentNode(null!));
    }

    [Fact]
    public void ToHcl_GeneratesCorrectHclSyntax()
    {
        const string commentText = "This is a comment";
        var comment = new TerraformCommentNode(commentText);
        var stack = new TerraformStack { Name = "test" };
        var context = new TerraformContext(stack);

        var hcl = comment.ToHcl(context);

        Assert.Equal("# This is a comment", hcl);
    }

    [Fact]
    public void ToHcl_WithEmptyText_GeneratesCommentWithHashOnly()
    {
        var comment = new TerraformCommentNode("");
        var stack = new TerraformStack { Name = "test" };
        var context = new TerraformContext(stack);

        var hcl = comment.ToHcl(context);

        Assert.Equal("# ", hcl);
    }

    [Fact]
    public void ToHcl_WithMultilineText_GeneratesSingleLineComment()
    {
        const string commentText = "Line 1\nLine 2";
        var comment = new TerraformCommentNode(commentText);
        var stack = new TerraformStack { Name = "test" };
        var context = new TerraformContext(stack);

        var hcl = comment.ToHcl(context);

        Assert.Equal("# Line 1\nLine 2", hcl);
    }
}
