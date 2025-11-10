using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for stage in .
/// Nesting mode: list
/// </summary>
public class AwsSsmcontactsPlanStageBlock : TerraformBlock
{
    /// <summary>
    /// The duration_in_minutes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DurationInMinutes is required")]
    public required TerraformProperty<double> DurationInMinutes
    {
        get => GetRequiredProperty<TerraformProperty<double>>("duration_in_minutes");
        set => WithProperty("duration_in_minutes", value);
    }

}

/// <summary>
/// Manages a aws_ssmcontacts_plan resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSsmcontactsPlan : TerraformResource
{
    public AwsSsmcontactsPlan(string name) : base("aws_ssmcontacts_plan", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The contact_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContactId is required")]
    public required TerraformProperty<string> ContactId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("contact_id");
        set => this.WithProperty("contact_id", value);
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
    /// Block for stage.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Stage block(s) required")]
    public List<AwsSsmcontactsPlanStageBlock>? Stage
    {
        get => GetProperty<List<AwsSsmcontactsPlanStageBlock>>("stage");
        set => this.WithProperty("stage", value);
    }

}
