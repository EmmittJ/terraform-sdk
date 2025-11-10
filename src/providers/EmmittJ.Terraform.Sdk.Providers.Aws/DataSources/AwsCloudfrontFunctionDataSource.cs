using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cloudfront_function.
/// </summary>
public class AwsCloudfrontFunctionDataSource : TerraformDataSource
{
    public AwsCloudfrontFunctionDataSource(string name) : base("aws_cloudfront_function", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("code");
        this.WithOutput("comment");
        this.WithOutput("etag");
        this.WithOutput("key_value_store_associations");
        this.WithOutput("last_modified_time");
        this.WithOutput("runtime");
        this.WithOutput("status");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The stage attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Stage is required")]
    public required TerraformProperty<string> Stage
    {
        get => GetRequiredProperty<TerraformProperty<string>>("stage");
        set => this.WithProperty("stage", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The code attribute.
    /// </summary>
    public TerraformExpression Code => this["code"];

    /// <summary>
    /// The comment attribute.
    /// </summary>
    public TerraformExpression Comment => this["comment"];

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// The key_value_store_associations attribute.
    /// </summary>
    public TerraformExpression KeyValueStoreAssociations => this["key_value_store_associations"];

    /// <summary>
    /// The last_modified_time attribute.
    /// </summary>
    public TerraformExpression LastModifiedTime => this["last_modified_time"];

    /// <summary>
    /// The runtime attribute.
    /// </summary>
    public TerraformExpression Runtime => this["runtime"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
