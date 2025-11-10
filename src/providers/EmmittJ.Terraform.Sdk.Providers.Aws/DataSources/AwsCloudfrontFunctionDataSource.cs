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
        SetOutput("arn");
        SetOutput("code");
        SetOutput("comment");
        SetOutput("etag");
        SetOutput("key_value_store_associations");
        SetOutput("last_modified_time");
        SetOutput("runtime");
        SetOutput("status");
        SetOutput("id");
        SetOutput("name");
        SetOutput("stage");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The stage attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Stage is required")]
    public required TerraformProperty<string> Stage
    {
        get => GetRequiredOutput<TerraformProperty<string>>("stage");
        set => SetProperty("stage", value);
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
