using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_prefix_list.
/// </summary>
public class AwsPrefixListDataSource : TerraformDataSource
{
    public AwsPrefixListDataSource(string name) : base("aws_prefix_list", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("cidr_blocks");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The prefix_list_id attribute.
    /// </summary>
    public string? PrefixListId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("prefix_list_id")?.Value;
        set => this.WithProperty("prefix_list_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cidr_blocks attribute.
    /// </summary>
    public TerraformExpression CidrBlocks => this["cidr_blocks"];

}
