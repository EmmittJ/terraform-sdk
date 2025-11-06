using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_service_linked_role resource.
/// </summary>
public class AwsIamServiceLinkedRole : TerraformResource
{
    public AwsIamServiceLinkedRole(string name) : base("aws_iam_service_linked_role", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("create_date");
        this.DeclareOutput("name");
        this.DeclareOutput("path");
        this.DeclareOutput("unique_id");
    }

    /// <summary>
    /// The aws_service_name attribute.
    /// </summary>
    public string? AwsServiceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("aws_service_name")?.Value;
        set => this.WithProperty("aws_service_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The custom_suffix attribute.
    /// </summary>
    public string? CustomSuffix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("custom_suffix")?.Value;
        set => this.WithProperty("custom_suffix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The create_date attribute.
    /// </summary>
    public TerraformExpression CreateDate => this["create_date"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformExpression Path => this["path"];

    /// <summary>
    /// The unique_id attribute.
    /// </summary>
    public TerraformExpression UniqueId => this["unique_id"];

}
