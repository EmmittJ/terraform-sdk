using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lambda_layer_version_permission resource.
/// </summary>
public class AwsLambdaLayerVersionPermission : TerraformResource
{
    public AwsLambdaLayerVersionPermission(string name) : base("aws_lambda_layer_version_permission", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("policy");
        SetOutput("revision_id");
        SetOutput("action");
        SetOutput("id");
        SetOutput("layer_name");
        SetOutput("organization_id");
        SetOutput("principal");
        SetOutput("region");
        SetOutput("skip_destroy");
        SetOutput("statement_id");
        SetOutput("version_number");
    }

    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformProperty<string> Action
    {
        get => GetRequiredOutput<TerraformProperty<string>>("action");
        set => SetProperty("action", value);
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
    /// The layer_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LayerName is required")]
    public required TerraformProperty<string> LayerName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("layer_name");
        set => SetProperty("layer_name", value);
    }

    /// <summary>
    /// The organization_id attribute.
    /// </summary>
    public TerraformProperty<string> OrganizationId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("organization_id");
        set => SetProperty("organization_id", value);
    }

    /// <summary>
    /// The principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principal is required")]
    public required TerraformProperty<string> Principal
    {
        get => GetRequiredOutput<TerraformProperty<string>>("principal");
        set => SetProperty("principal", value);
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
    /// The skip_destroy attribute.
    /// </summary>
    public TerraformProperty<bool> SkipDestroy
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("skip_destroy");
        set => SetProperty("skip_destroy", value);
    }

    /// <summary>
    /// The statement_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StatementId is required")]
    public required TerraformProperty<string> StatementId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("statement_id");
        set => SetProperty("statement_id", value);
    }

    /// <summary>
    /// The version_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VersionNumber is required")]
    public required TerraformProperty<double> VersionNumber
    {
        get => GetRequiredOutput<TerraformProperty<double>>("version_number");
        set => SetProperty("version_number", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformExpression Policy => this["policy"];

    /// <summary>
    /// The revision_id attribute.
    /// </summary>
    public TerraformExpression RevisionId => this["revision_id"];

}
