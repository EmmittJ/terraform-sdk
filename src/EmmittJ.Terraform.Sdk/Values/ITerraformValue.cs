namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Marker interface for TerraformValue&lt;T&gt; to enable non-reflection based value resolution.
/// All TerraformValue&lt;T&gt; types implement this interface to provide polymorphic resolution.
/// </summary>
public interface ITerraformValue : ITerraformResolvable
{
}
