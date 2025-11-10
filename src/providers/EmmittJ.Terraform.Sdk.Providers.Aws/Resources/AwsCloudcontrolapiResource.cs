using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsCloudcontrolapiResourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_cloudcontrolapi_resource resource.
/// </summary>
public class AwsCloudcontrolapiResource : TerraformResource
{
    public AwsCloudcontrolapiResource(string name) : base("aws_cloudcontrolapi_resource", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("properties");
        SetOutput("desired_state");
        SetOutput("id");
        SetOutput("region");
        SetOutput("role_arn");
        SetOutput("schema");
        SetOutput("type_name");
        SetOutput("type_version_id");
    }

    /// <summary>
    /// The desired_state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DesiredState is required")]
    public required TerraformProperty<string> DesiredState
    {
        get => GetRequiredOutput<TerraformProperty<string>>("desired_state");
        set => SetProperty("desired_state", value);
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
    /// The schema attribute.
    /// </summary>
    public TerraformProperty<string> Schema
    {
        get => GetRequiredOutput<TerraformProperty<string>>("schema");
        set => SetProperty("schema", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsCloudcontrolapiResourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The properties attribute.
    /// </summary>
    public TerraformExpression Properties => this["properties"];

}
