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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
        this.DeclareOutput("properties");
    }

    /// <summary>
    /// The desired_state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DesiredState is required")]
    public required TerraformProperty<string> DesiredState
    {
        get => GetProperty<TerraformProperty<string>>("desired_state");
        set => this.WithProperty("desired_state", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => this.WithProperty("role_arn", value);
    }

    /// <summary>
    /// The schema attribute.
    /// </summary>
    public TerraformProperty<string>? Schema
    {
        get => GetProperty<TerraformProperty<string>>("schema");
        set => this.WithProperty("schema", value);
    }

    /// <summary>
    /// The type_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TypeName is required")]
    public required TerraformProperty<string> TypeName
    {
        get => GetProperty<TerraformProperty<string>>("type_name");
        set => this.WithProperty("type_name", value);
    }

    /// <summary>
    /// The type_version_id attribute.
    /// </summary>
    public TerraformProperty<string>? TypeVersionId
    {
        get => GetProperty<TerraformProperty<string>>("type_version_id");
        set => this.WithProperty("type_version_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsCloudcontrolapiResourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsCloudcontrolapiResourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The properties attribute.
    /// </summary>
    public TerraformExpression Properties => this["properties"];

}
