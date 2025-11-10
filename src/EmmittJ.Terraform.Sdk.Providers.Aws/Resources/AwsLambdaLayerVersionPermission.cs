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
        this.DeclareOutput("policy");
        this.DeclareOutput("revision_id");
    }

    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformProperty<string> Action
    {
        get => GetProperty<TerraformProperty<string>>("action");
        set => this.WithProperty("action", value);
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
    /// The layer_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LayerName is required")]
    public required TerraformProperty<string> LayerName
    {
        get => GetProperty<TerraformProperty<string>>("layer_name");
        set => this.WithProperty("layer_name", value);
    }

    /// <summary>
    /// The organization_id attribute.
    /// </summary>
    public TerraformProperty<string>? OrganizationId
    {
        get => GetProperty<TerraformProperty<string>>("organization_id");
        set => this.WithProperty("organization_id", value);
    }

    /// <summary>
    /// The principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principal is required")]
    public required TerraformProperty<string> Principal
    {
        get => GetProperty<TerraformProperty<string>>("principal");
        set => this.WithProperty("principal", value);
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
    /// The skip_destroy attribute.
    /// </summary>
    public TerraformProperty<bool>? SkipDestroy
    {
        get => GetProperty<TerraformProperty<bool>>("skip_destroy");
        set => this.WithProperty("skip_destroy", value);
    }

    /// <summary>
    /// The statement_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StatementId is required")]
    public required TerraformProperty<string> StatementId
    {
        get => GetProperty<TerraformProperty<string>>("statement_id");
        set => this.WithProperty("statement_id", value);
    }

    /// <summary>
    /// The version_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VersionNumber is required")]
    public required TerraformProperty<double> VersionNumber
    {
        get => GetProperty<TerraformProperty<double>>("version_number");
        set => this.WithProperty("version_number", value);
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
