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
    public string? Action
    {
        get => GetProperty<TerraformLiteralProperty<string>>("action")?.Value;
        set => this.WithProperty("action", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The layer_name attribute.
    /// </summary>
    public string? LayerName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("layer_name")?.Value;
        set => this.WithProperty("layer_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The organization_id attribute.
    /// </summary>
    public string? OrganizationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("organization_id")?.Value;
        set => this.WithProperty("organization_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The principal attribute.
    /// </summary>
    public string? Principal
    {
        get => GetProperty<TerraformLiteralProperty<string>>("principal")?.Value;
        set => this.WithProperty("principal", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    public bool? SkipDestroy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("skip_destroy")?.Value;
        set => this.WithProperty("skip_destroy", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The statement_id attribute.
    /// </summary>
    public string? StatementId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("statement_id")?.Value;
        set => this.WithProperty("statement_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The version_number attribute.
    /// </summary>
    public double? VersionNumber
    {
        get => GetProperty<TerraformLiteralProperty<double>>("version_number")?.Value;
        set => this.WithProperty("version_number", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
