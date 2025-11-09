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
    public TerraformProperty<string>? AwsServiceName
    {
        get => GetProperty<TerraformProperty<string>>("aws_service_name");
        set => this.WithProperty("aws_service_name", value);
    }

    /// <summary>
    /// The custom_suffix attribute.
    /// </summary>
    public TerraformProperty<string>? CustomSuffix
    {
        get => GetProperty<TerraformProperty<string>>("custom_suffix");
        set => this.WithProperty("custom_suffix", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
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
