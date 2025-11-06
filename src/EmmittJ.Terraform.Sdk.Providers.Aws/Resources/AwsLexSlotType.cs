using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lex_slot_type resource.
/// </summary>
public class AwsLexSlotType : TerraformResource
{
    public AwsLexSlotType(string name) : base("aws_lex_slot_type", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("checksum");
        this.DeclareOutput("created_date");
        this.DeclareOutput("last_updated_date");
        this.DeclareOutput("version");
    }

    /// <summary>
    /// The create_version attribute.
    /// </summary>
    public bool? CreateVersion
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("create_version")?.Value;
        set => this.WithProperty("create_version", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The value_selection_strategy attribute.
    /// </summary>
    public string? ValueSelectionStrategy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("value_selection_strategy")?.Value;
        set => this.WithProperty("value_selection_strategy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The checksum attribute.
    /// </summary>
    public TerraformExpression Checksum => this["checksum"];

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    public TerraformExpression CreatedDate => this["created_date"];

    /// <summary>
    /// The last_updated_date attribute.
    /// </summary>
    public TerraformExpression LastUpdatedDate => this["last_updated_date"];

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformExpression Version => this["version"];

}
