using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for portal_options in .
/// Nesting mode: list
/// </summary>
public class AwsSsoadminApplicationPortalOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The visibility attribute.
    /// </summary>
    public TerraformProperty<string>? Visibility
    {
        set => SetProperty("visibility", value);
    }

}

/// <summary>
/// Manages a aws_ssoadmin_application resource.
/// </summary>
public class AwsSsoadminApplication : TerraformResource
{
    public AwsSsoadminApplication(string name) : base("aws_ssoadmin_application", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("application_account");
        SetOutput("application_arn");
        SetOutput("arn");
        SetOutput("id");
        SetOutput("tags_all");
        SetOutput("application_provider_arn");
        SetOutput("client_token");
        SetOutput("description");
        SetOutput("instance_arn");
        SetOutput("name");
        SetOutput("region");
        SetOutput("status");
        SetOutput("tags");
    }

    /// <summary>
    /// The application_provider_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationProviderArn is required")]
    public required TerraformProperty<string> ApplicationProviderArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("application_provider_arn");
        set => SetProperty("application_provider_arn", value);
    }

    /// <summary>
    /// The client_token attribute.
    /// </summary>
    public TerraformProperty<string> ClientToken
    {
        get => GetRequiredOutput<TerraformProperty<string>>("client_token");
        set => SetProperty("client_token", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The instance_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceArn is required")]
    public required TerraformProperty<string> InstanceArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance_arn");
        set => SetProperty("instance_arn", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string> Status
    {
        get => GetRequiredOutput<TerraformProperty<string>>("status");
        set => SetProperty("status", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for portal_options.
    /// Nesting mode: list
    /// </summary>
    public List<AwsSsoadminApplicationPortalOptionsBlock>? PortalOptions
    {
        set => SetProperty("portal_options", value);
    }

    /// <summary>
    /// The application_account attribute.
    /// </summary>
    public TerraformExpression ApplicationAccount => this["application_account"];

    /// <summary>
    /// The application_arn attribute.
    /// </summary>
    public TerraformExpression ApplicationArn => this["application_arn"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
