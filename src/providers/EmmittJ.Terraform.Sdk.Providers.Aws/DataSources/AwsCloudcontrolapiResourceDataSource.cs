using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cloudcontrolapi_resource.
/// </summary>
public class AwsCloudcontrolapiResourceDataSource : TerraformDataSource
{
    public AwsCloudcontrolapiResourceDataSource(string name) : base("aws_cloudcontrolapi_resource", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("properties");
        SetOutput("id");
        SetOutput("identifier");
        SetOutput("region");
        SetOutput("role_arn");
        SetOutput("type_name");
        SetOutput("type_version_id");
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
    /// The identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identifier is required")]
    public required TerraformProperty<string> Identifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("identifier");
        set => SetProperty("identifier", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformProperty<string> RoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role_arn");
        set => SetProperty("role_arn", value);
    }

    /// <summary>
    /// The type_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TypeName is required")]
    public required TerraformProperty<string> TypeName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type_name");
        set => SetProperty("type_name", value);
    }

    /// <summary>
    /// The type_version_id attribute.
    /// </summary>
    public TerraformProperty<string> TypeVersionId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type_version_id");
        set => SetProperty("type_version_id", value);
    }

    /// <summary>
    /// The properties attribute.
    /// </summary>
    public TerraformExpression Properties => this["properties"];

}
